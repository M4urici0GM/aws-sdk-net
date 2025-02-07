/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Object describing a participant that has joined a stage.
    /// </summary>
    public partial class Participant
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _browserName;
        private string _browserVersion;
        private DateTime? _firstJoinTime;
        private string _ispName;
        private string _osName;
        private string _osVersion;
        private string _participantId;
        private bool? _published;
        private string _sdkVersion;
        private ParticipantState _state;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Application-provided attributes to encode into the token and attach to a stage. Map
        /// keys and values can contain UTF-8 encoded text. The maximum length of this field is
        /// 1 KB total. <i>This field is exposed to all stage participants and should not be used
        /// for personally identifying, confidential, or sensitive information</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BrowserName. 
        /// <para>
        /// The participant’s browser.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string BrowserName
        {
            get { return this._browserName; }
            set { this._browserName = value; }
        }

        // Check to see if BrowserName property is set
        internal bool IsSetBrowserName()
        {
            return this._browserName != null;
        }

        /// <summary>
        /// Gets and sets the property BrowserVersion. 
        /// <para>
        /// The participant’s browser version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string BrowserVersion
        {
            get { return this._browserVersion; }
            set { this._browserVersion = value; }
        }

        // Check to see if BrowserVersion property is set
        internal bool IsSetBrowserVersion()
        {
            return this._browserVersion != null;
        }

        /// <summary>
        /// Gets and sets the property FirstJoinTime. 
        /// <para>
        /// ISO 8601 timestamp (returned as a string) when the participant first joined the stage
        /// session.
        /// </para>
        /// </summary>
        public DateTime FirstJoinTime
        {
            get { return this._firstJoinTime.GetValueOrDefault(); }
            set { this._firstJoinTime = value; }
        }

        // Check to see if FirstJoinTime property is set
        internal bool IsSetFirstJoinTime()
        {
            return this._firstJoinTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IspName. 
        /// <para>
        /// The participant’s Internet Service Provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string IspName
        {
            get { return this._ispName; }
            set { this._ispName = value; }
        }

        // Check to see if IspName property is set
        internal bool IsSetIspName()
        {
            return this._ispName != null;
        }

        /// <summary>
        /// Gets and sets the property OsName. 
        /// <para>
        /// The participant’s operating system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string OsName
        {
            get { return this._osName; }
            set { this._osName = value; }
        }

        // Check to see if OsName property is set
        internal bool IsSetOsName()
        {
            return this._osName != null;
        }

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The participant’s operating system version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string OsVersion
        {
            get { return this._osVersion; }
            set { this._osVersion = value; }
        }

        // Check to see if OsVersion property is set
        internal bool IsSetOsVersion()
        {
            return this._osVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// Unique identifier for this participant, assigned by IVS.
        /// </para>
        /// </summary>
        public string ParticipantId
        {
            get { return this._participantId; }
            set { this._participantId = value; }
        }

        // Check to see if ParticipantId property is set
        internal bool IsSetParticipantId()
        {
            return this._participantId != null;
        }

        /// <summary>
        /// Gets and sets the property Published. 
        /// <para>
        /// Whether the participant ever published to the stage session.
        /// </para>
        /// </summary>
        public bool Published
        {
            get { return this._published.GetValueOrDefault(); }
            set { this._published = value; }
        }

        // Check to see if Published property is set
        internal bool IsSetPublished()
        {
            return this._published.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SdkVersion. 
        /// <para>
        /// The participant’s SDK version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string SdkVersion
        {
            get { return this._sdkVersion; }
            set { this._sdkVersion = value; }
        }

        // Check to see if SdkVersion property is set
        internal bool IsSetSdkVersion()
        {
            return this._sdkVersion != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Whether the participant is connected to or disconnected from the stage.
        /// </para>
        /// </summary>
        public ParticipantState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Customer-assigned name to help identify the token; this can be used to link a participant
        /// to a user in the customer’s own systems. This can be any UTF-8 encoded text. <i>This
        /// field is exposed to all stage participants and should not be used for personally identifying,
        /// confidential, or sensitive information</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}