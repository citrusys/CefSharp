// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.WebAudio
{
    /// <summary>
    /// Protocol object for AudioNode
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class AudioNode : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// NodeId
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("nodeId"), IsRequired = (true))]
        public string NodeId
        {
            get;
            set;
        }

        /// <summary>
        /// ContextId
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("contextId"), IsRequired = (true))]
        public string ContextId
        {
            get;
            set;
        }

        /// <summary>
        /// NodeType
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("nodeType"), IsRequired = (true))]
        public string NodeType
        {
            get;
            set;
        }

        /// <summary>
        /// NumberOfInputs
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("numberOfInputs"), IsRequired = (true))]
        public long NumberOfInputs
        {
            get;
            set;
        }

        /// <summary>
        /// NumberOfOutputs
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("numberOfOutputs"), IsRequired = (true))]
        public long NumberOfOutputs
        {
            get;
            set;
        }

        /// <summary>
        /// ChannelCount
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("channelCount"), IsRequired = (true))]
        public long ChannelCount
        {
            get;
            set;
        }

        /// <summary>
        /// ChannelCountMode
        /// </summary>
        public Fluxonaut.Browser.DevTools.WebAudio.ChannelCountMode ChannelCountMode
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.WebAudio.ChannelCountMode)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.WebAudio.ChannelCountMode), channelCountMode));
            }

            set
            {
                channelCountMode = (EnumToString(value));
            }
        }

        /// <summary>
        /// ChannelCountMode
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("channelCountMode"), IsRequired = (true))]
        internal string channelCountMode
        {
            get;
            set;
        }

        /// <summary>
        /// ChannelInterpretation
        /// </summary>
        public Fluxonaut.Browser.DevTools.WebAudio.ChannelInterpretation ChannelInterpretation
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.WebAudio.ChannelInterpretation)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.WebAudio.ChannelInterpretation), channelInterpretation));
            }

            set
            {
                channelInterpretation = (EnumToString(value));
            }
        }

        /// <summary>
        /// ChannelInterpretation
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("channelInterpretation"), IsRequired = (true))]
        internal string channelInterpretation
        {
            get;
            set;
        }
    }
}