using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;


namespace StackByLinkedList_001
{
    public partial class MainForm : Form
    {

        public List<Stack<double>> stacks = new List<Stack<double>>();
        private Stack<double> sourceStack;
        private Stack<double> targetStack;
        private double? bufferNumber = null;

        public void RefreshStacksList()
        {
            stacksList.DataSource = null;
            stacksList.DataSource = stacks;
        }

        public MainForm()
        {
            InitializeComponent();
        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Multiselect = false,
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "|*.dat"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream stream = File.Open(dialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        stacks = formatter.Deserialize(stream) as List<Stack<double>>;
                        RefreshStacksList();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "|*.dat",
                InitialDirectory = Directory.GetCurrentDirectory()
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream stream = File.Open(dialog.FileName, FileMode.OpenOrCreate))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, stacks);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }


        private void addEmptyStackBtn_Click(object sender, EventArgs e)
        {
            stacks.Add(new Stack<double>());
            RefreshStacksList();
        }

        private void setAsSourceStackBtn_Click(object sender, EventArgs e)
        {
            if (stacksList.SelectedIndex != -1)
            {
                sourceStack = stacks[stacksList.SelectedIndex];
                srcStackHashCodeLabel.Text = sourceStack.GetHashCode().ToString();
            }
            else
            {
                MessageBox.Show("Select Stack From List Box!");
            }
        }

        private void setAsTargetBtn_Click(object sender, EventArgs e)
        {
            if (stacksList.SelectedIndex != -1)
            {
                targetStack = stacks[stacksList.SelectedIndex];
                targetStackHashCodeLabel.Text = targetStack.GetHashCode().ToString();
            }
            else
            {
                MessageBox.Show("Select Stack From List Box!");
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(inputNumberTextBox.Text, out number))
            {
                if (targetStack != null)
                {
                    targetStack.Push(number);
                    RefreshStacksList();
                }
                else
                {
                    MessageBox.Show("Select Target Stack From List Box!");
                }
            }
            else
            {
                MessageBox.Show("Please input number!");
            }
        }

        private void popFromSourceBtn_Click(object sender, EventArgs e)
        {
            if (sourceStack != null)
            {
                try
                {
                    bufferNumber = sourceStack.Pop();
                    bufferValueLabel.Text = bufferNumber.ToString();
                    RefreshStacksList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select Source Stack!");
            }
        }

        private void pushToTargetBtn_Click(object sender, EventArgs e)
        {
            if (targetStack == null)
            {
                MessageBox.Show("Please Select Target Stack!");
                return;
            }
            else if (bufferNumber == null)
            {
                MessageBox.Show("Buffer number is empty!");
                return;
            }
            else
            {
                targetStack.Push(bufferNumber.Value);
                bufferNumber = null;
                bufferValueLabel.Text = string.Empty;
                RefreshStacksList();
            }
        }

        private void stacksList_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }
    }
}
