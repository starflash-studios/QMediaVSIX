// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IFirstSignInSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ExclusiveTo(typeof (FirstSignInSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1049907539, 14942, 17710, 166, 1, 245, 186, 173, 42, 72, 112)]
  internal interface IFirstSignInSettings : 
    IMapView<string, object>,
    IIterable<IKeyValuePair<string, object>>
  {
  }
}
