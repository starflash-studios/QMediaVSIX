// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlLoadSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [Guid(1487538088, 65238, 18167, 180, 197, 251, 27, 167, 33, 8, 214)]
  [ExclusiveTo(typeof (XmlLoadSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IXmlLoadSettings
  {
    uint MaxElementDepth { get; set; }

    bool ProhibitDtd { get; set; }

    bool ResolveExternals { get; set; }

    bool ValidateOnParse { get; set; }

    bool ElementContentWhiteSpace { get; set; }
  }
}
