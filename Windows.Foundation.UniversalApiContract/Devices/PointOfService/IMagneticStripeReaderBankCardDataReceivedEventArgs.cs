// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderBankCardDataReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (MagneticStripeReaderBankCardDataReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(781551651, 41754, 18275, 136, 44, 35, 114, 94, 57, 176, 142)]
  internal interface IMagneticStripeReaderBankCardDataReceivedEventArgs
  {
    MagneticStripeReaderReport Report { get; }

    string AccountNumber { get; }

    string ExpirationDate { get; }

    string ServiceCode { get; }

    string Title { get; }

    string FirstName { get; }

    string MiddleInitial { get; }

    string Surname { get; }

    string Suffix { get; }
  }
}
