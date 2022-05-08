namespace Su_Doku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            createBoard();

            StartNewGame();
        }

        Field[,] fields = new Field[9, 9];
        private void createBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    fields[i, j] = new Field();
                    fields[i, j].Location = new Point(i * 40, j * 40);

                    fields[i, j].Size = new Size(40, 40);
                    fields[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? Color.PapayaWhip : Color.PeachPuff;
                    fields[i, j].FlatStyle = FlatStyle.Standard;
                    fields[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 23);

                    fields[i, j].FlatAppearance.BorderColor = Color.Peru;

                    fields[i, j].KeyPress += Field_keyPressed;
                    fields[i, j].KeyDown += Field_keyDown;
                    panel1.Controls.Add(fields[i, j]);
                }
            }
        }

        private void Field_keyPressed(object sender, KeyPressEventArgs e)
        {
            var field = sender as Field;

            if (field.IsLocked)
                return;

            int value;

            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                if (value == 0)
                    field.Clear();
                else
                    field.Text = value.ToString();

                field.ForeColor = Color.DarkOliveGreen;
            }
        }

        private void Field_keyDown(object sender, KeyEventArgs e)
        {
            var field = sender as Field;
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                field.Clear();
            }
        }

        private async void StartNewGame()
        {
            panel2.Show();
            ActivateButtons(activation: false);
            ResetTable();
            LoadValues();
            var valuesToDisplay = await Task.Run(() => PrepareNewTable());
            populateFieldsFromIntTable(valuesToDisplay);
            ActivateButtons(activation: true);
            panel2.Hide();
        }

        private void ActivateButtons(bool activation)
        {
            var buttons = this.Controls.OfType<Button>();
            foreach(var button in buttons)
            {
                if (button.Enabled != activation &&
                    button.Name != "exitButton")
                    button.Enabled = activation;
            }
            //this.hintButton.Enabled = activation;
            //this.clearAllButton.Enabled = activation;
            //this.checkButton.Enabled = activation;
            //this.newGameButton.Enabled = activation;
        }

        private async Task<int[,]> PrepareNewTable()
        {
            

            //var defaultValues = 60;
            var valuesToDisplay = PuzzleGenerator.GeneratePuzzle(convertToIntTable(fields));
            return valuesToDisplay;
            //showDefaultValues(defaultValues);
        }

        private void ResetTable()
        {
            foreach (var field in fields)
            {
                field.ForeColor = Color.Black;
            }
        }

        private int[,] convertToIntTable(Field[,] fields)
        {
            int[,] allValues = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    allValues[i, j] = fields[i, j].Value;
                }
            }
            return allValues;
        }

        private void populateFieldsFromIntTable(int[,] values)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (values[i, j] != 0)
                    {
                        fields[i, j].Text = fields[i, j].Value.ToString();
                        fields[i, j].IsLocked = true;
                    }        
                }
            }
        }

        private void LoadValues()
        {
            foreach (var field in fields)
            {
                field.Value = 0;
                field.Clear();
            }

            PopulateFields(0, -1);
        }

        Random random = new Random();
        private bool PopulateFields(int i, int j)
        {
            if (++j > 8)
            {
                j = 0;

                if (++i > 8)
                    return true;
            }

            var value = 0;
            var valuesLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            do
            {
                if (valuesLeft.Count < 1)
                {
                    fields[i, j].Value = 0;
                    return false;
                }

                value = valuesLeft[random.Next(0, valuesLeft.Count)];
                fields[i, j].Value = value;

                valuesLeft.Remove(value);
            }

            while (!IsValueValid(value, i, j) || !PopulateFields(i, j));
            //fields[i, j].Text = value.ToString(); // svi brojevi 

            return true;
        }

        private bool IsValueValid(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                // vertikalna provjera
                if (i != y && fields[x, i].Value == value)
                    return false;

                // horizontalna provjera
                if (i != x && fields[i, y].Value == value)
                    return false;
            }

            //provjera bloka 3x3
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && fields[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            bool isFull = true;

            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (String.IsNullOrEmpty(fields[i, j].Text))
                    {
                        isFull = false;
                    }
                }
            }

            if (isFull)
            {
                MessageBox.Show("All fields are full.");
                return;
            }
           
            bool isHintCompleted = false;

            while (!isHintCompleted)
            {
                var hintField = randomField();
                int x = hintField.Item1;
                int y = hintField.Item2;

                if (String.IsNullOrEmpty(fields[x, y].Text))
                {
                    fields[x, y].Text = fields[x, y].Value.ToString();
                    fields[x, y].ForeColor = Color.OliveDrab;
                    fields[x, y].IsLocked = true;

                    isHintCompleted = true;
                }
            }

        }

        private Tuple<int, int> randomField()
        {
            var random = new Random();

            int x = random.Next(9);
            int y = random.Next(9);

            return new Tuple<int, int>(x, y);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to erase all of your inputs?", "Think again...!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var field in fields)
                {

                    if (field.IsLocked == false)
                        field.Clear();
                }
            }
            else
                return;
          
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            var wrongInput = new List<Field>();

            foreach (var field in fields)
            {
                if (!string.Equals(field.Value.ToString(), field.Text))
                {
                   wrongInput.Add(field);
                }
            }

            //unosi su ispravni ili pogresni 
            if (wrongInput.Any())
            {
                //netacne cifre crvenes 
                wrongInput.ForEach(x => x.ForeColor = Color.IndianRed);
                
                MessageBox.Show("Nope. Try again.");
            }
            else
            {
                MessageBox.Show("Nicely done!");
                StartNewGame();
            }

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You sure?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                StartNewGame();
            }
            else
                return;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the game?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else
                return;
        }
    }

}