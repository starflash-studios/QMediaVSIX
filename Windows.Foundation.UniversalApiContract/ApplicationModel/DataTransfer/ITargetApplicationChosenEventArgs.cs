// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ITargetApplicationChosenEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(3396319404, 10631, 20195, 156, 84, 216, 175, 188, 184, 108, 29)]
  [ExclusiveTo(typeof (TargetApplicationChosenEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITargetApplicationChosenEventArgs
  {
    string ApplicationName { get; }
  }
}
