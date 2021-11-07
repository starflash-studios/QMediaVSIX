// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StoreLogOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  /// <summary>Defines options that can be specified while using GetStoreLogDataAsync to get Microsoft Store log data for the current device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Flags]
  public enum StoreLogOptions : uint
  {
    /// <summary>No log options are specified.</summary>
    None = 0,
    /// <summary>Try to get log data with elevated privileges.</summary>
    TryElevate = 1,
  }
}
