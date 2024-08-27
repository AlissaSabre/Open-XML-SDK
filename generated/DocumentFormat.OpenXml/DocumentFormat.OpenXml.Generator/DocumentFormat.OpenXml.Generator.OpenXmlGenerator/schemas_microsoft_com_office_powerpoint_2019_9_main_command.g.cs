﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2016.Presentation.Command;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command
{
    /// <summary>
    /// <para>Defines the CommentV2MonikerList Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc2:cmMkLst.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Presentation.Command.SlideMonikerList" /> <c>&lt;pc:sldMkLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentV2Moniker" /> <c>&lt;pc2:cmMK></c></description></item>
    /// </list>
    /// </remarks>
    public partial class CommentV2MonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentV2MonikerList class.
        /// </summary>
        public CommentV2MonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentV2MonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentV2MonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentV2MonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentV2MonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentV2MonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentV2MonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc2:cmMkLst");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Presentation.Command.SlideMonikerList>();
            builder.AddChild<DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentV2Moniker>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Presentation.Command.SlideMonikerList), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentV2Moniker), 1, 1, version: FileFormatVersions.Microsoft365)
            };
        }

        /// <summary>
        /// <para>SlideMonikerList.</para>
        /// <para>Represents the following element tag in the schema: pc:sldMkLst.</para>
        /// </summary>
        /// <remarks>
        /// xmlns:pc = http://schemas.microsoft.com/office/powerpoint/2013/main/command
        /// </remarks>
        public DocumentFormat.OpenXml.Office2016.Presentation.Command.SlideMonikerList? SlideMonikerList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Presentation.Command.SlideMonikerList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CommentV2Moniker.</para>
        /// <para>Represents the following element tag in the schema: pc2:cmMK.</para>
        /// </summary>
        /// <remarks>
        /// xmlns:pc2 = http://schemas.microsoft.com/office/powerpoint/2019/9/main/command
        /// </remarks>
        public DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentV2Moniker? CommentV2Moniker
        {
            get => GetElement<DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentV2Moniker>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentV2MonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentReplyV2MonikerList Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc2:cmRplyMkLst.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentReplyV2Moniker" /> <c>&lt;pc2:cmRplyMk></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentV2MonikerList" /> <c>&lt;pc2:cmMkLst></c></description></item>
    /// </list>
    /// </remarks>
    public partial class CommentReplyV2MonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentReplyV2MonikerList class.
        /// </summary>
        public CommentReplyV2MonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentReplyV2MonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentReplyV2MonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentReplyV2MonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentReplyV2MonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentReplyV2MonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentReplyV2MonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc2:cmRplyMkLst");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddChild<DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentReplyV2Moniker>();
            builder.AddChild<DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentV2MonikerList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentV2MonikerList), 1, 1, version: FileFormatVersions.Microsoft365),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentReplyV2Moniker), 1, 1, version: FileFormatVersions.Microsoft365)
            };
        }

        /// <summary>
        /// <para>CommentV2MonikerList.</para>
        /// <para>Represents the following element tag in the schema: pc2:cmMkLst.</para>
        /// </summary>
        /// <remarks>
        /// xmlns:pc2 = http://schemas.microsoft.com/office/powerpoint/2019/9/main/command
        /// </remarks>
        public DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentV2MonikerList? CommentV2MonikerList
        {
            get => GetElement<DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentV2MonikerList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CommentReplyV2Moniker.</para>
        /// <para>Represents the following element tag in the schema: pc2:cmRplyMk.</para>
        /// </summary>
        /// <remarks>
        /// xmlns:pc2 = http://schemas.microsoft.com/office/powerpoint/2019/9/main/command
        /// </remarks>
        public DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentReplyV2Moniker? CommentReplyV2Moniker
        {
            get => GetElement<DocumentFormat.OpenXml.Office.PowerPoint.Y2019.Main.Command.CommentReplyV2Moniker>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentReplyV2MonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentV2Moniker Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc2:cmMK.</para>
    /// </summary>
    public partial class CommentV2Moniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentV2Moniker class.
        /// </summary>
        public CommentV2Moniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc2:cmMK");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddElement<CommentV2Moniker>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentV2Moniker>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentReplyV2Moniker Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc2:cmRplyMk.</para>
    /// </summary>
    public partial class CommentReplyV2Moniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentReplyV2Moniker class.
        /// </summary>
        public CommentReplyV2Moniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc2:cmRplyMk");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddElement<CommentReplyV2Moniker>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentReplyV2Moniker>(deep);
    }
}