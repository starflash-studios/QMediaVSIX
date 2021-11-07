// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.XmlDomImplementation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  /// <summary>Provides methods that are independent of any particular instance of the document object model.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class XmlDomImplementation : IXmlDomImplementation
  {
    /// <summary>Indicates support for the specified feature.</summary>
    /// <param name="feature">Specifies the feature to test. In Level 1, valid feature values are "XML", "DOM", and "MS-DOM" (case-insensitive).</param>
    /// <param name="version">Specifies the version number to test. If NULL, tests for implementation of the feature in any version. In Level 1, "1.0" is the valid version value.</param>
    /// <returns>True if the specified feature is implemented; otherwise false.</returns>
    [MethodImpl]
    public extern bool HasFeature(string feature, [Variant] object version);
  }
}
