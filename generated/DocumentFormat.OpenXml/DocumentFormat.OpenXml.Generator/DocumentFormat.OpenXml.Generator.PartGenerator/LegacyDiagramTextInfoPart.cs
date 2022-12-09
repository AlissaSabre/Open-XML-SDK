﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the LegacyDiagramTextInfoPart
    /// </summary>
    public partial class LegacyDiagramTextInfoPart : TypedOpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-office.legacyDocTextInfo";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/legacyDocTextInfo";

        /// <summary>
        /// Creates an instance of the LegacyDiagramTextInfoPart OpenXmlType
        /// </summary>
        internal protected LegacyDiagramTextInfoPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Extension => ".bin";
            string ITargetFeature.Name => "legacyDocTextInfo";
        }
    
    }
}
