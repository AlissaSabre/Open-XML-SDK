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
    /// Defines the DocumentTasksPart
    /// </summary>
    public partial class DocumentTasksPart : TypedOpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-office.documenttasks+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2019/05/relationships/documenttasks";
        private DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks? _rootElement;

        /// <summary>
        /// Creates an instance of the DocumentTasksPart OpenXmlType
        /// </summary>
        internal protected DocumentTasksPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => Tasks;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks Tasks
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks>();
                }

                return _rootElement!;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2021);
        }
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "tasks";
        }
    
    }
}
