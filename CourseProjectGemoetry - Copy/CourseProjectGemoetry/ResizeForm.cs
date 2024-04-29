using CourseProjectGemoetry.UndoRedo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjectGemoetry
{
    public partial class ResizeForm : Form
    {

        // Properties for new width and height
        public int NewWidth { get; private set; }
        public int NewHeight { get; private set; }

        public int NewStrokeSize { get; private set; }
        //private CommandManager commandManager = new CommandManager();

        public ResizeForm(int initialWidth, int initialHeight, int initialStrokeSize)
        {
            InitializeComponent();
            widthTextBox.Text = initialWidth.ToString();
            heightTextBox.Text = initialHeight.ToString();
            strokeSizeTextBox.Text = initialStrokeSize.ToString();
        }


        private void resizeButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(widthTextBox.Text, out int width) && int.TryParse(heightTextBox.Text, out int height) && int.TryParse(strokeSizeTextBox.Text, out int strokeSize))
            {
                // Set new width and height properties
                NewWidth = width;
                NewHeight = height;
                NewStrokeSize = strokeSize;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please enter valid width and height values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
