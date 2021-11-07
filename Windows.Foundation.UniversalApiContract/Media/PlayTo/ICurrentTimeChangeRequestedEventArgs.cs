// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.ICurrentTimeChangeRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [Guid(2574324516, 60871, 19445, 145, 246, 60, 134, 39, 219, 89, 229)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CurrentTimeChangeRequestedEventArgs))]
  internal interface ICurrentTimeChangeRequestedEventArgs
  {
    TimeSpan Time { get; }
  }
}
