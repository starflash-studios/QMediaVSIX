// Decompiled with JetBrains decompiler
// Type: Windows.System.IKnownUserPropertiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (KnownUserProperties))]
  [Guid(2002096410, 28869, 18661, 182, 55, 91, 163, 68, 30, 78, 228)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKnownUserPropertiesStatics
  {
    string DisplayName { get; }

    string FirstName { get; }

    string LastName { get; }

    string ProviderName { get; }

    string AccountName { get; }

    string GuestHost { get; }

    string PrincipalName { get; }

    string DomainName { get; }

    string SessionInitiationProtocolUri { get; }
  }
}
