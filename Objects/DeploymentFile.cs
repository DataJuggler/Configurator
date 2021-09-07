

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace Configurator.Objects
{

    #region class DeploymentFile
    /// <summary>
    /// This class is used to unpack the files.
    /// </summary>
    public class DeploymentFile
    {
        
        #region Private Variables
        private string source;
        private string target;
        #endregion

        #region Properties

            #region Source
            /// <summary>
            /// This property gets or sets the value for 'Source'.
            /// </summary>
            public string Source
            {
                get { return source; }
                set { source = value; }
            }
            #endregion
            
            #region Target
            /// <summary>
            /// This property gets or sets the value for 'Target'.
            /// </summary>
            public string Target
            {
                get { return target; }
                set { target = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
