using Calculadora_Areas_Perimetros.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Areas_Perimetros
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;
        // Change the color of your buttons if you want
        Color btnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        Color btnSelectedtColor = Color.FromKnownColor(KnownColor.ControlDark);
        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }
        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>() // Your UserControl list
            { new Circle(), new Heptagon(), new Squaer__(), new Trapezoid(),new Triangle()};

            navigationControl = new NavigationControl(userControls, panel2); 
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { btnTriangle, btnSquare, btnTrapezoid, btnCircle, btnHeptagon };
            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
            navigationButtons.Highlight(btnTriangle);
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(btnSquare);
        }

        private void btnTrapezoid_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButtons.Highlight(btnTrapezoid);
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(btnCircle);
        }

        private void btnHeptagon_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(btnHeptagon);
        }
    }
}
