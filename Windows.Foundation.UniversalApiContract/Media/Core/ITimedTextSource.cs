// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimedTextSource))]
  [Guid(3303906214, 4127, 16461, 169, 73, 130, 243, 63, 205, 147, 183)]
  internal interface ITimedTextSource
  {
    event TypedEventHandler<TimedTextSource, TimedTextSourceResolveResultEventArgs> Resolved;
  }
}
