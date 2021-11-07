// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplication2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CoreApplication))]
  [WebHostHidden]
  [Guid(2575729147, 6838, 19327, 190, 74, 154, 6, 69, 34, 76, 4)]
  internal interface ICoreApplication2
  {
    event EventHandler<BackgroundActivatedEventArgs> BackgroundActivated;

    event EventHandler<LeavingBackgroundEventArgs> LeavingBackground;

    event EventHandler<EnteredBackgroundEventArgs> EnteredBackground;

    void EnablePrelaunch(bool value);
  }
}
