// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingConnectionErrorOccurredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [ExclusiveTo(typeof (CastingConnectionErrorOccurredEventArgs))]
  [Guid(2818260073, 34585, 20224, 129, 251, 150, 24, 99, 199, 154, 50)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICastingConnectionErrorOccurredEventArgs
  {
    CastingConnectionErrorStatus ErrorStatus { get; }

    string Message { get; }
  }
}
