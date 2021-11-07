// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUnhandledExceptionEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(1915758236, 1358, 19699, 134, 197, 190, 144, 235, 104, 99, 213)]
  [ExclusiveTo(typeof (UnhandledExceptionEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUnhandledExceptionEventArgs
  {
    HResult Exception { get; }

    string Message { get; }

    bool Handled { get; set; }
  }
}
