// Decompiled with JetBrains decompiler
// Type: Windows.UI.Shell.ShareWindowCommandEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Shell
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  public sealed class ShareWindowCommandEventArgs : IShareWindowCommandEventArgs
  {
    public extern WindowId WindowId { [MethodImpl] get; }

    public extern ShareWindowCommand Command { [MethodImpl] get; [MethodImpl] set; }
  }
}
