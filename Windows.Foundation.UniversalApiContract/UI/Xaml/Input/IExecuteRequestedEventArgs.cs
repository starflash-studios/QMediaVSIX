// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IExecuteRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (ExecuteRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3766462260, 41142, 22357, 158, 135, 36, 245, 76, 202, 147, 114)]
  [WebHostHidden]
  internal interface IExecuteRequestedEventArgs
  {
    object Parameter { get; }
  }
}
