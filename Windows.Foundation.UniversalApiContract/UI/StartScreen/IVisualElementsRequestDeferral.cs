// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IVisualElementsRequestDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2707779248, 294, 17239, 130, 4, 189, 130, 187, 42, 4, 109)]
  [ExclusiveTo(typeof (VisualElementsRequestDeferral))]
  internal interface IVisualElementsRequestDeferral
  {
    void Complete();
  }
}
