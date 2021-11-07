// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserDeviceAssociationChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3172953964, 47965, 19835, 165, 240, 200, 205, 17, 163, 141, 66)]
  [ExclusiveTo(typeof (UserDeviceAssociationChangedEventArgs))]
  internal interface IUserDeviceAssociationChangedEventArgs
  {
    string DeviceId { get; }

    User NewUser { get; }

    User OldUser { get; }
  }
}
