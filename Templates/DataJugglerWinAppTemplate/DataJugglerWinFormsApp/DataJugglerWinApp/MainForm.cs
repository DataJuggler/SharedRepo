
#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace $safeprojectname$
{

    #region class MainForm
    /// <summary>
    /// This is the main form for this application.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Private Variables
        private int leftMargin;
        private int rightMargin;
        private int topMargin;
        private int bottomMargin;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

        #endregion

        #region Methods

        #region Init()
        /// <summary>
        /// This method performs initializations for this object.
        /// </summary>
        public void Init()
        {
            // Set the default value of the margin panels
            this.LeftMargin = 16;
            this.TopMargin = 16;
            this.RightMargin = 16;
            this.BottomMargin = 16;

            // add any initialization code here
        }
        #endregion

        #endregion

        #region Properties

            #region BottomMargin
            /// <summary>
            /// This property gets or sets the value for 'BottomMargin'.
            /// </summary>
            public int BottomMargin
            {
                get { return bottomMargin; }
                set
                {
                    // set the value
                    bottomMargin = value;

                    // set the value of the control
                    BottomMarginPanel.Height = bottomMargin;
                }
            }
            #endregion

            #region CreateParams
            /// <summary>
            /// This property here is what did the trick to reduce the flickering.
            /// I also needed to make all of the controls Double Buffered, but
            /// this was the final touch. It is a little slow when you switch tabs
            /// but that is because the repainting is finishing before control is
            /// returned.
            /// </summary>
            protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
            #endregion

            #region LeftMargin
            /// <summary>
            /// This property gets or sets the value for 'LeftMargin'.
            /// </summary>
            public int LeftMargin
            {
                get { return leftMargin; }
                set
                {
                    // set the value
                    leftMargin = value;

                    // set the value of the control
                    LeftMarginPanel.Width = leftMargin;
                }
            }
            #endregion

            #region RightMargin
            /// <summary>
            /// This property gets or sets the value for 'RightMargin'.
            /// </summary>
            public int RightMargin
            {
                get { return rightMargin; }
                set
                {
                    // set the value
                    rightMargin = value;

                    // set the width of the control
                    RightMarginPanel.Width = rightMargin;
                }
            }
            #endregion

            #region TopMargin
            /// <summary>
            /// This property gets or sets the value for 'TopMargin'.
            /// </summary>
            public int TopMargin
            {
                get { return topMargin; }
                set
                {
                    // set the value
                    topMargin = value;

                    // set the height of the control
                    TopMarginPanel.Height = topMargin;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
