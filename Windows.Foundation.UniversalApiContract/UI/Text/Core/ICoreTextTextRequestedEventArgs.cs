// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextTextRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextTextRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4036403920, 16838, 19458, 139, 26, 217, 83, 176, 12, 171, 179)]
  internal interface ICoreTextTextRequestedEventArgs
  {
    CoreTextTextRequest Request { get; }
  }
}
