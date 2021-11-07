// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserChangedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (UserChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(1798097732, 28417, 22028, 151, 173, 252, 127, 50, 236, 88, 31)]
  internal interface IUserChangedEventArgs2
  {
    IVectorView<UserWatcherUpdateKind> ChangedPropertyKinds { get; }
  }
}
