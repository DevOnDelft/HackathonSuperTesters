namespace TestAgileCockpit
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    
    
    public partial class UIMap
    {
        /// <summary>
        /// navigateAndSelectTeam
        /// </summary>
        public void navigateAndSelectTeam()
        {
            #region Variable Declarations
            Microsoft.VisualStudio.TestTools.UITesting.WinControls.WinWindow uIAgileCockpitAppListGWindow1 = this.UIAgileCockpitAppListGWindow.UIAgileCockpitAppListGWindow1;
            #endregion

            // Click 'Agile Cockpit - App List - Google Chrome' window
            Mouse.Click(uIAgileCockpitAppListGWindow1, new Point(422, 111));

            // Click 'Agile Cockpit - App List - Google Chrome' window
            Mouse.Click(uIAgileCockpitAppListGWindow1, new Point(445, 225));
        }

        /// <summary>
        /// selectTaskBoard
        /// </summary>
        public void selectTaskBoard()
        {
            #region Variable Declarations
            Microsoft.VisualStudio.TestTools.UITesting.WinControls.WinWindow uIAgileCockpitAppListGWindow1 = this.UIAgileCockpitAppListGWindow.UIAgileCockpitAppListGWindow1;
            #endregion

            // Click 'Agile Cockpit - App List - Google Chrome' window
            Mouse.Click(uIAgileCockpitAppListGWindow1, new Point(793, 403));
        }

        #region Properties
        public UIAgileCockpitAppListGWindow UIAgileCockpitAppListGWindow
        {
            get
            {
                if ((this.mUIAgileCockpitAppListGWindow == null))
                {
                    this.mUIAgileCockpitAppListGWindow = new UIAgileCockpitAppListGWindow();
                }
                return this.mUIAgileCockpitAppListGWindow;
            }
        }
        #endregion

        #region Fields
        private UIAgileCockpitAppListGWindow mUIAgileCockpitAppListGWindow;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIAgileCockpitAppListGWindow : Microsoft.VisualStudio.TestTools.UITesting.WinControls.WinWindow
    {

        public UIAgileCockpitAppListGWindow()
        {
            #region Search Criteria
            this.SearchProperties[Microsoft.VisualStudio.TestTools.UITesting.WinControls.WinWindow.PropertyNames.Name] = "Agile Cockpit - App List - Google Chrome";
            this.SearchProperties[Microsoft.VisualStudio.TestTools.UITesting.WinControls.WinWindow.PropertyNames.ClassName] = "Chrome_WidgetWin_1";
            this.WindowTitles.Add("Agile Cockpit - App List - Google Chrome");
            #endregion
        }

        #region Properties
        public Microsoft.VisualStudio.TestTools.UITesting.WinControls.WinWindow UIAgileCockpitAppListGWindow1
        {
            get
            {
                if ((this.mUIAgileCockpitAppListGWindow1 == null))
                {
                    this.mUIAgileCockpitAppListGWindow1 = new Microsoft.VisualStudio.TestTools.UITesting.WinControls.WinWindow(this);
                    #region Search Criteria
                    this.mUIAgileCockpitAppListGWindow1.SearchProperties[Microsoft.VisualStudio.TestTools.UITesting.WinControls.WinWindow.PropertyNames.Name] = "Agile Cockpit - App List";
                    this.mUIAgileCockpitAppListGWindow1.WindowTitles.Add("Agile Cockpit - App List - Google Chrome");
                    #endregion
                }
                return this.mUIAgileCockpitAppListGWindow1;
            }
        }
        #endregion

        #region Fields
        private Microsoft.VisualStudio.TestTools.UITesting.WinControls.WinWindow mUIAgileCockpitAppListGWindow1;
        #endregion
    }
}
