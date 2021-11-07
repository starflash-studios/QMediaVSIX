// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.ServiceRequestedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Represents the method that handles the data passed by the MediaProtectionManager when the resume operation is completed.</summary>
  /// <param name="sender">Contains the MediaProtectionManager object that is requesting the service.</param>
  /// <param name="e">Contains event data for a MediaProtectionManager object when a service is requested.</param>
  [Guid(3537277114, 51913, 18657, 149, 192, 211, 132, 149, 168, 64, 85)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void ServiceRequestedEventHandler(
    MediaProtectionManager sender,
    ServiceRequestedEventArgs e);
}
