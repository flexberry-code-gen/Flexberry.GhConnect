﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.GhConnect
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// New class1.
    /// </summary>
    //  *** Start programmer edit section *** (NewClass1 CustomAttributes)

    //  *** End programmer edit section *** (NewClass1 CustomAttributes)
    [AutoAltered()]
    [Caption("New class1")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("NewClass1E", new string[] {
            "NewAttr as \'New attr\'"})]
    [View("NewClass1L", new string[] {
            "NewAttr as \'New attr\'"})]
    public class NewClass1 : ICSSoft.STORMNET.DataObject
    {
        
        private string fNewAttr;
        
        //  *** Start programmer edit section *** (NewClass1 CustomMembers)

        //  *** End programmer edit section *** (NewClass1 CustomMembers)

        
        /// <summary>
        /// NewAttr.
        /// </summary>
        //  *** Start programmer edit section *** (NewClass1.NewAttr CustomAttributes)

        //  *** End programmer edit section *** (NewClass1.NewAttr CustomAttributes)
        [StrLen(255)]
        public virtual string NewAttr
        {
            get
            {
                //  *** Start programmer edit section *** (NewClass1.NewAttr Get start)

                //  *** End programmer edit section *** (NewClass1.NewAttr Get start)
                string result = this.fNewAttr;
                //  *** Start programmer edit section *** (NewClass1.NewAttr Get end)

                //  *** End programmer edit section *** (NewClass1.NewAttr Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (NewClass1.NewAttr Set start)

                //  *** End programmer edit section *** (NewClass1.NewAttr Set start)
                this.fNewAttr = value;
                //  *** Start programmer edit section *** (NewClass1.NewAttr Set end)

                //  *** End programmer edit section *** (NewClass1.NewAttr Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "NewClass1E" view.
            /// </summary>
            public static ICSSoft.STORMNET.View NewClass1E
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("NewClass1E", typeof(IIS.GhConnect.NewClass1));
                }
            }
            
            /// <summary>
            /// "NewClass1L" view.
            /// </summary>
            public static ICSSoft.STORMNET.View NewClass1L
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("NewClass1L", typeof(IIS.GhConnect.NewClass1));
                }
            }
        }
    }
}
