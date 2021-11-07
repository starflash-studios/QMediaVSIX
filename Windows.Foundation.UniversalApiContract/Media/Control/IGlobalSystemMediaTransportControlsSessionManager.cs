// Decompiled with JetBrains decompiler
// Type: Windows.Media.Control.IGlobalSystemMediaTransportControlsSessionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Control
{
  [Guid(3402534572, 59502, 20554, 171, 49, 95, 248, 255, 27, 206, 73)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSessionManager))]
  internal interface IGlobalSystemMediaTransportControlsSessionManager
  {
    GlobalSystemMediaTransportControlsSession GetCurrentSession();

    IVectorView<GlobalSystemMediaTransportControlsSession> GetSessions();

    event TypedEventHandler<GlobalSystemMediaTransportControlsSessionManager, CurrentSessionChangedEventArgs> CurrentSessionChanged;

    event TypedEventHandler<GlobalSystemMediaTransportControlsSessionManager, SessionsChangedEventArgs> SessionsChanged;
  }
}
