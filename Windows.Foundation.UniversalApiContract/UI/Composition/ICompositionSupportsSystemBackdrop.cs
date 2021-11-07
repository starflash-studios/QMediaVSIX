// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionSupportsSystemBackdrop
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(964538340, 46786, 23481, 149, 29, 245, 112, 125, 232, 183, 188)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  public interface ICompositionSupportsSystemBackdrop
  {
    CompositionBrush SystemBackdrop { get; set; }
  }
}
