// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(1540175023, 9449, 19472, 141, 7, 20, 195, 70, 186, 63, 206)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintTaskCompletedEventArgs))]
  internal interface IPrintTaskCompletedEventArgs
  {
    PrintTaskCompletion Completion { get; }
  }
}
