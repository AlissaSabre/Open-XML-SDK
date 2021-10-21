﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the LabelInfoPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2021)]
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class LabelInfoPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-office.classificationlabels+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2020/02/relationships/classificationlabels";
        private DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList? _rootElement;

        /// <summary>
        /// Creates an instance of the LabelInfoPart OpenXmlType
        /// </summary>
        internal protected LabelInfoPart()
        {
        }

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList ClassificationLabelList
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList>();
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
                _rootElement = value as DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => ClassificationLabelList;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "LabelInfo";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "docMetadata";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2021);
        }
    }
}
