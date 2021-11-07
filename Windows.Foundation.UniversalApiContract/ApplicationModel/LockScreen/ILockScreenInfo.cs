// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.ILockScreenInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.LockScreen
{
  [ExclusiveTo(typeof (LockScreenInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4120553052, 38673, 19913, 166, 48, 149, 182, 203, 140, 218, 208)]
  internal interface ILockScreenInfo
  {
    event TypedEventHandler<LockScreenInfo, object> LockScreenImageChanged;

    IRandomAccessStream LockScreenImage { get; }

    event TypedEventHandler<LockScreenInfo, object> BadgesChanged;

    IVectorView<LockScreenBadge> Badges { get; }

    event TypedEventHandler<LockScreenInfo, object> DetailTextChanged;

    IVectorView<string> DetailText { get; }

    event TypedEventHandler<LockScreenInfo, object> AlarmIconChanged;

    IRandomAccessStream AlarmIcon { get; }
  }
}
