// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICurrentChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ExclusiveTo(typeof (CurrentChangingEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4186512937, 20940, 18397, 165, 185, 53, 220, 73, 20, 175, 105)]
  internal interface ICurrentChangingEventArgs
  {
    bool Cancel { get; set; }

    bool IsCancelable { get; }
  }
}
