// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskRegistration2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Provides access to a registered background task. Inherits from the IBackgroundTaskRegistration interface and adds the Trigger property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1631110915, 48006, 16658, 175, 195, 127, 147, 155, 22, 110, 59)]
  public interface IBackgroundTaskRegistration2 : IBackgroundTaskRegistration
  {
    /// <summary>Gets the trigger associated with the background task.</summary>
    /// <returns>The trigger associated with the background task.</returns>
    IBackgroundTrigger Trigger { get; }
  }
}
