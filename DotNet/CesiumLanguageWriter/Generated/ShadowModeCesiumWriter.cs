// <auto-generated>
// This file was generated automatically by GenerateFromSchema. Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using JetBrains.Annotations;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>ShadowMode</c> to a <see cref="CesiumOutputStream" />. A <c>ShadowMode</c> is whether or not an object casts or receives shadows from each light source when shadows are enabled.
    /// </summary>
    public class ShadowModeCesiumWriter : CesiumPropertyWriter<ShadowModeCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>shadowMode</c> property.
        /// </summary>
        public const string ShadowModePropertyName = "shadowMode";

        /// <summary>
        /// The name of the <c>reference</c> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        /// <summary>
        /// The name of the <c>delete</c> property.
        /// </summary>
        public const string DeletePropertyName = "delete";

        private readonly Lazy<ICesiumValuePropertyWriter<CesiumShadowMode>> m_asShadowMode;
        private readonly Lazy<ICesiumValuePropertyWriter<Reference>> m_asReference;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public ShadowModeCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
            m_asShadowMode = new Lazy<ICesiumValuePropertyWriter<CesiumShadowMode>>(CreateShadowModeAdaptor, false);
            m_asReference = new Lazy<ICesiumValuePropertyWriter<Reference>>(CreateReferenceAdaptor, false);
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected ShadowModeCesiumWriter([NotNull] ShadowModeCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asShadowMode = new Lazy<ICesiumValuePropertyWriter<CesiumShadowMode>>(CreateShadowModeAdaptor, false);
            m_asReference = new Lazy<ICesiumValuePropertyWriter<Reference>>(CreateReferenceAdaptor, false);
        }

        /// <inheritdoc />
        public override ShadowModeCesiumWriter Clone()
        {
            return new ShadowModeCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>shadowMode</c>, which is the shadow mode.
        /// </summary>
        /// <param name="value">The shadow mode.</param>
        public void WriteShadowMode(CesiumShadowMode value)
        {
            const string PropertyName = ShadowModePropertyName;
            if (ForceInterval)
            {
                OpenIntervalIfNecessary();
            }
            if (IsInterval)
            {
                Output.WritePropertyName(PropertyName);
            }
            Output.WriteValue(CesiumFormattingHelper.ShadowModeToString(value));
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the shadow mode specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(Reference value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the shadow mode specified as a reference to another property.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteReference(string value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the shadow mode specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteReference(string identifier, string propertyName)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyName);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the shadow mode specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteReference(string identifier, string[] propertyNames)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyNames);
        }

        /// <summary>
        /// Writes the value expressed as a <c>delete</c>, which is whether the client should delete existing samples or interval data for this property. Data will be deleted for the containing interval, or if there is no containing interval, then all data. If true, all other properties in this property will be ignored.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDelete(bool value)
        {
            const string PropertyName = DeletePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            Output.WriteValue(value);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumValuePropertyWriter{T}" /> to write a value in <c>ShadowMode</c> format. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumValuePropertyWriter<CesiumShadowMode> AsShadowMode()
        {
            return m_asShadowMode.Value;
        }

        private ICesiumValuePropertyWriter<CesiumShadowMode> CreateShadowModeAdaptor()
        {
            return new CesiumWriterAdaptor<ShadowModeCesiumWriter, CesiumShadowMode>(this, (me, value) => me.WriteShadowMode(value));
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumValuePropertyWriter{T}" /> to write a value in <c>Reference</c> format. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumValuePropertyWriter<Reference> AsReference()
        {
            return m_asReference.Value;
        }

        private ICesiumValuePropertyWriter<Reference> CreateReferenceAdaptor()
        {
            return new CesiumWriterAdaptor<ShadowModeCesiumWriter, Reference>(this, (me, value) => me.WriteReference(value));
        }

    }
}
