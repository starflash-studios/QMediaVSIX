// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileOpenPicker3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage.Pickers
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (FileOpenPicker))]
  [Guid(3651519923, 50652, 23448, 189, 128, 168, 208, 202, 5, 132, 216)]
  internal interface IFileOpenPicker3
  {
    User User { get; }
  }
}
