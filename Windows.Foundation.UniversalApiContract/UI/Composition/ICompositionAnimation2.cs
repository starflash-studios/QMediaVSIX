// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionAnimation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionAnimation))]
  [Guid(916152382, 43023, 18760, 147, 227, 237, 35, 251, 56, 198, 203)]
  internal interface ICompositionAnimation2
  {
    void SetBooleanParameter(string key, bool value);

    string Target { get; set; }
  }
}
