using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Village.Cultivated.Field.Protection.RNVillageCultivatedFieldProtection
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNVillageCultivatedFieldProtectionModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNVillageCultivatedFieldProtectionModule"/>.
        /// </summary>
        internal RNVillageCultivatedFieldProtectionModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNVillageCultivatedFieldProtection";
            }
        }
    }
}
