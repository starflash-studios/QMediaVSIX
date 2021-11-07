// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDataContextChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (DataContextChangedEventArgs))]
  [Guid(2108067361, 2959, 20383, 161, 67, 248, 231, 120, 1, 54, 162)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataContextChangedEventArgs
  {
    object NewValue { get; }

    bool Handled { get; set; }
  }
}
