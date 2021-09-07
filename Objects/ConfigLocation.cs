

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configurator.Enumerations;

#endregion

namespace Configurator.Objects
{

    #region class ConfigLocation
    /// <summary>
    /// This class represents one config file and its path.
    /// </summary>
    public class ConfigLocation
    {
        
        #region Private Variables
        private string filePath;
        private string projectName;
        private ConfigTypeEnum configType;
        #endregion

        #region Properties
            
            #region ConfigType
            /// <summary>
            /// This property gets or sets the value for 'ConfigType'.
            /// </summary>
            public ConfigTypeEnum ConfigType
            {
                get { return configType; }
                set { configType = value; }
            }
            #endregion
            
            #region FilePath
            /// <summary>
            /// This property gets or sets the value for 'FilePath'.
            /// </summary>
            public string FilePath
            {
                get { return filePath; }
                set { filePath = value; }
            }
            #endregion
            
            #region ProjectName
            /// <summary>
            /// This property gets or sets the value for 'ProjectName'.
            /// </summary>
            public string ProjectName
            {
                get { return projectName; }
                set { projectName = value; }
            }
            #endregion
            
        #endregion

        
    }
    #endregion

}
