// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivityRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [ExclusiveTo(typeof (UserActivityRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(2764864076, 33321, 19709, 163, 188, 198, 29, 49, 133, 117, 164)]
  internal interface IUserActivityRequestedEventArgs
  {
    UserActivityRequest Request { get; }

    Deferral GetDeferral();
  }
}
