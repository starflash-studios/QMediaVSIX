// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemMediaProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SystemMediaProperties))]
  [Guid(2754294550, 33813, 16604, 140, 68, 152, 54, 29, 35, 84, 48)]
  internal interface ISystemMediaProperties
  {
    string Duration { get; }

    string Producer { get; }

    string Publisher { get; }

    string SubTitle { get; }

    string Writer { get; }

    string Year { get; }
  }
}
