// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  /// <summary>Represents a custom attribute not defined in the specification.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ISyndicationAttributeFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  public sealed class SyndicationAttribute : ISyndicationAttribute
  {
    /// <summary>Creates a new SyndicationAttribute object with the specified **Name**, **Namespace**, and **Value** property values.</summary>
    /// <param name="attributeName">The name of the attribute.</param>
    /// <param name="attributeNamespace">The namespace of the attribute.</param>
    /// <param name="attributeValue">The value of the attribute.</param>
    [MethodImpl]
    public extern SyndicationAttribute(
      string attributeName,
      string attributeNamespace,
      string attributeValue);

    /// <summary>Creates a new SyndicationAttribute object.</summary>
    [MethodImpl]
    public extern SyndicationAttribute();

    /// <summary>Gets the name of the syndication attribute.</summary>
    /// <returns>The **atom:name** element.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the namespace of the attribute.</summary>
    /// <returns>The namespace of the attribute.</returns>
    public extern string Namespace { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value of the attribute.</summary>
    /// <returns>The value of the attribute.</returns>
    public extern string Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
