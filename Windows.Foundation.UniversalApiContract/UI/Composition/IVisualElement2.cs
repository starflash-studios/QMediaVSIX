// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVisualElement2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [Guid(2570774688, 24663, 24128, 145, 140, 224, 110, 11, 126, 124, 100)]
  [WebHostHidden]
  public interface IVisualElement2
  {
    Visual GetVisualInternal();
  }
}
