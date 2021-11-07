// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.IPickerClosingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ExclusiveTo(typeof (PickerClosingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2119823908, 45874, 20242, 139, 159, 168, 194, 240, 107, 50, 205)]
  internal interface IPickerClosingEventArgs
  {
    PickerClosingOperation ClosingOperation { get; }

    bool IsCanceled { get; }
  }
}
