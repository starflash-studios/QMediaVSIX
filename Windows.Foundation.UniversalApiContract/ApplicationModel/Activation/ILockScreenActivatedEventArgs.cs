// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ILockScreenActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about an event that occurs when the app is activated as the lock screen.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1017608550, 24840, 19009, 130, 32, 238, 125, 19, 60, 133, 50)]
  public interface ILockScreenActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets an object that allows an app that is activated as the lock screen to get the same data that the default lock screen can access, and to register for updates to that data.</summary>
    /// <returns>An object that allows an app that is activated as the lock screen to get the same data that the default lock screen can access, and to register for updates to that data.</returns>
    object Info { get; }
  }
}
