// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ApplicationDataSetVersionHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Represents a method that handles the request to set the version of the application data in the application data store.</summary>
  /// <param name="setVersionRequest">The set version request.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2690093542, 52383, 18055, 172, 171, 163, 100, 253, 120, 84, 99)]
  public delegate void ApplicationDataSetVersionHandler(SetVersionRequest setVersionRequest);
}
