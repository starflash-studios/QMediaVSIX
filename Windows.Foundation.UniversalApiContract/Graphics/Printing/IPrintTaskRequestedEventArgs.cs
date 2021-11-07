// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(3501193508, 41755, 17740, 167, 182, 93, 12, 197, 34, 252, 22)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintTaskRequestedEventArgs))]
  internal interface IPrintTaskRequestedEventArgs
  {
    PrintTaskRequest Request { get; }
  }
}
