using CourseProjectGemoetry.Figure_classes;
using CourseProjectGemoetry.UndoRedo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CourseProjectGemoetry
{
    public partial class Form1 : Form
    {
        private List<Figure> figures = new List<Figure>();
        private Point startPoint;
        private FigureType currentFigureType;
        private Figure currentFigure;
        private Point currentMousePosition;
        private int currentStrokeSize = 2;
        private Color outlineColor = Color.Black;
        private Color fillColor = Color.Transparent;
        private Figure selectedFigure;
        private Point lastMousePosition;
        private CommandManager commandManager = new CommandManager();
        private int deltaX;
        private int deltaY;

        public Form1()
        {
            InitializeComponent();
            figureSelector.DataSource = Enum.GetValues(typeof(FigureType));
            currentFigureType = FigureType.Rectangle;
            textBoxStrokeSize.TextChanged += TextBoxStrokeSize_TextChanged;

        }

        private void TextBoxStrokeSize_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxStrokeSize.Text, out int strokeSize))
            {
                if (strokeSize > 0)
                {
                    currentStrokeSize = strokeSize;
                }
                else
                {
                    textBoxStrokeSize.Text = currentStrokeSize.ToString();
                }
            }
            else
            {
                textBoxStrokeSize.Text = currentStrokeSize.ToString();
            }
        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure figure in figures)
            {
                figure.Fill(e.Graphics);
                figure.Draw(e.Graphics);
            }
            if (startPoint != Point.Empty && currentFigure != null && drawButton.Enabled == false)
            {
                currentFigure.SetDimensions(startPoint, currentMousePosition);
                currentFigure.Fill(e.Graphics);
                currentFigure.Draw(e.Graphics);
            }
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                startPoint = e.Location;
                if (moveFigure.Enabled == false)
                {
                    foreach (Figure figure in figures)
                    {
                        if (figure.ContainsPoint(e.Location))
                        {
                            selectedFigure = figure;
                            deltaX = selectedFigure.X;
                            deltaY = selectedFigure.Y;
                            lastMousePosition = e.Location;
                            break;
                        }
                    }
                }
                else if (eraserButton.Enabled == false)
                {
                    foreach (Figure figure in figures)
                    {
                        if (figure.ContainsPoint(e.Location))
                        {
                            ICommand addCommand = new RemoveFigureCommand(figures, figure);
                            commandManager.ExecuteCommand(addCommand);
                            break;
                        }
                    }
                }
                else if (changeFillColor.Enabled == false)
                {

                    foreach (Figure figure in figures)
                    {
                        if (figure.ContainsPoint(e.Location))
                        {
                            selectedFigure = figure;
                            break;
                        }
                    }
                    ColorDialog colorDialog = new ColorDialog();
                    if (colorDialog.ShowDialog() == DialogResult.OK && selectedFigure != null)
                    {
                        ICommand command = new FillCommand(selectedFigure, selectedFigure.FillColor, colorDialog.Color);
                        commandManager.ExecuteCommand(command);
                    }
                }
                else if (changeOutlineColor.Enabled == false)
                {
                    foreach (Figure figure in figures)
                    {
                        if (figure.ContainsPoint(e.Location))
                        {
                            selectedFigure = figure;
                            break;
                        }
                    }
                    ColorDialog colorDialog = new ColorDialog();
                    if (colorDialog.ShowDialog() == DialogResult.OK && selectedFigure != null)
                    {
                        ICommand command = new OutlineCommand(selectedFigure, selectedFigure.PenColor, colorDialog.Color);
                        commandManager.ExecuteCommand(command);
                    }
                }
                else if (drawButton.Enabled == false)
                {
                    switch (currentFigureType)
                    {
                        case FigureType.Rectangle:
                            if (Control.ModifierKeys == Keys.Shift)
                            {
                                currentFigure = new SquareFigure(startPoint.X, startPoint.Y, 0, currentStrokeSize, outlineColor, fillColor);
                            }
                            else
                            {
                                currentFigure = new RectangleFigure(startPoint.X, startPoint.Y, 0, 0, currentStrokeSize, outlineColor, fillColor);
                            }
                            break;
                        case FigureType.Ellipse:
                            if (Control.ModifierKeys == Keys.Shift)
                            {
                                currentFigure = new CircleFigure(startPoint.X, startPoint.Y, 0, currentStrokeSize, outlineColor, fillColor);
                            }
                            else
                            {
                                currentFigure = new EllipseFigure(startPoint.X, startPoint.Y, 0, 0, currentStrokeSize, outlineColor, fillColor);
                            }
                            break;
                        case FigureType.Triangle:
                            if (Control.ModifierKeys == Keys.Shift)
                            {
                                currentFigure = new EquilateralTriangle(startPoint.X, startPoint.Y, 0, currentStrokeSize, outlineColor, fillColor);
                            }
                            else
                            {
                                currentFigure = new TriangleFigure(startPoint.X, startPoint.Y, 0, 0, currentStrokeSize, outlineColor, fillColor);
                            }
                            break;
                    }
                    ICommand addCommand = new AddFigureCommand(figures, currentFigure);
                    commandManager.ExecuteCommand(addCommand);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                // Iterate through figures to find the selected one
                foreach (Figure figure in figures)
                {
                    if (figure.ContainsPoint(e.Location))
                    {
                        selectedFigure = figure;
                        ShowResizeForm();
                        break;
                    }
                }
            }

            Invalidate();
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = $"X: {e.Location.X}, Y: {e.Location.Y}";
            currentMousePosition = e.Location;
            if (selectedFigure != null && moveFigure.Enabled == false && e.Button == MouseButtons.Left)
            {
                int deltaX = e.Location.X - lastMousePosition.X;
                int deltaY = e.Location.Y - lastMousePosition.Y;
                selectedFigure.Move(deltaX, deltaY);
                lastMousePosition = e.Location;
            }
            Invalidate();
        }
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawButton.Enabled == false && currentFigure != null)
            {
                currentFigure.SetDimensions(startPoint, e.Location);
            }
            else
            {
                if (selectedFigure != null && moveFigure.Enabled == false && e.Button == MouseButtons.Left)
                {
                    ICommand moveCommand = new MoveCommand(selectedFigure, deltaX, deltaY);
                    commandManager.ExecuteCommand(moveCommand);
                }
            }
            selectedFigure = null;
            Invalidate();
            startPoint = Point.Empty;
        }

        private void ShowResizeForm()
        {
            using (var resizeForm = new ResizeForm(selectedFigure.Width, selectedFigure.Height, selectedFigure.StrokeSize))
            {
                if (resizeForm.ShowDialog() == DialogResult.OK)
                {
                    ICommand resizeCommand = new ResizeCommand(
                selectedFigure,
                selectedFigure.Width,
                resizeForm.NewWidth,
                selectedFigure.Height,
                resizeForm.NewHeight,
                selectedFigure.StrokeSize,
                resizeForm.NewStrokeSize
            );
                    commandManager.ExecuteCommand(resizeCommand);
                    Invalidate();
                }
            }
        }

        private void figureSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFigureType = (FigureType)figureSelector.SelectedItem;
        }

        private void fillColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                fillColor = colorDialog.Color;
                Invalidate();
            }
        }

        private void outlineColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                outlineColor = colorDialog.Color;
                Invalidate();
            }
        }

        private void clearBoardButton_Click(object sender, EventArgs e)
        {
            figures.Clear();
            Invalidate();
        }

        private void moveFigure_Click(object sender, EventArgs e)
        {
            moveFigure.Enabled = false;
            drawButton.Enabled = true;
            changeFillColor.Enabled = true;
            changeOutlineColor.Enabled = true;
            eraserButton.Enabled = true;
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            drawButton.Enabled = false;
            moveFigure.Enabled = true;
            changeFillColor.Enabled = true;
            changeOutlineColor.Enabled = true;
            eraserButton.Enabled = true;
        }

        private void changeFillColor_Click(object sender, EventArgs e)
        {
            changeFillColor.Enabled = false;
            moveFigure.Enabled = true;
            drawButton.Enabled = true;
            changeOutlineColor.Enabled = true;
            eraserButton.Enabled = true;
        }

        private void changeOutlineColor_Click(object sender, EventArgs e)
        {
            changeOutlineColor.Enabled = false;
            changeFillColor.Enabled = true;
            moveFigure.Enabled = true;
            drawButton.Enabled = true;
            eraserButton.Enabled = true;
        }
        private void eraserButton_Click(object sender, EventArgs e)
        {
            eraserButton.Enabled = false;
            changeOutlineColor.Enabled = true;
            changeFillColor.Enabled = true;
            moveFigure.Enabled = true;
            drawButton.Enabled = true;
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HelpForm = new HelpForm();
            HelpForm.Show();
        }

        private void undoCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandManager.Undo();
            Invalidate();
        }

        private void redoCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandManager.Redo();
            Invalidate();
        }
        private void Undo()
        {
            commandManager.Undo();
            Invalidate();
        }

        private void Redo()
        {
            commandManager.Redo();
            Invalidate();
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                Undo();
            }
            else if (e.Control && e.KeyCode == Keys.X)
            {
                Redo();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "JSON files (*.json)|*.json";
            saveFile.Title = "Open";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    Formatting = Formatting.Indented
                };
                string fileName =saveFile.FileName;
                string json = JsonConvert.SerializeObject(figures, settings);
                File.WriteAllText(fileName, json);
            }
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JSON files (*.json)|*.json";
            openFile.Title = "Open";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    Formatting = Formatting.Indented
                };
                string fileName = openFile.FileName;
                string json = File.ReadAllText(fileName);
                var loadedFigures = JsonConvert.DeserializeObject<List<Figure>>(json, settings);
                figures.Clear();
                figures.AddRange(loadedFigures);
                Invalidate();
            }
        }
    }
}

