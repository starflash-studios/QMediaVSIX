// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserAuthenticationStatusChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserAuthenticationStatusChangingEventArgs))]
  [Guid(2349010728, 42769, 19486, 171, 72, 4, 23, 156, 21, 147, 143)]
  internal interface IUserAuthenticationStatusChangingEventArgs
  {
    UserAuthenticationStatusChangeDeferral GetDeferral();

    User User { get; }

    UserAuthenticationStatus NewStatus { get; }

    UserAuthenticationStatus CurrentStatus { get; }
  }
}
