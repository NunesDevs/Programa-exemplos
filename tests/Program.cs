using ExemploPOO.Models;
using ExemploPOO.Helper;
using System;
using System.IO;
void Check(bool condition) { if (!condition) throw new Exception("Falha de regressão"); }
var conta=new Corrente(); conta.Creditar(10);conta.Creditar(5);Check(conta.Saldo==15);
try { conta.Creditar(-1); throw new Exception("Crédito negativo aceito"); } catch (ArgumentOutOfRangeException) {}
var calculadora=new Calculadora();Check(calculadora.Somar(2,3)==5);
try { calculadora.Somar(int.MaxValue,1); throw new Exception("Overflow silencioso"); } catch (OverflowException) {}
try { calculadora.Dividir(1,0); throw new Exception("Divisão inválida aceita"); } catch (DivideByZeroException) {}
var retangulo=new Retangulo();retangulo.DefinirMedidas(2,3);Check(retangulo.ObterArea()==6);
retangulo.DefinirMedidas(-1,3);Check(retangulo.ObterArea()==0);
var path=Path.Combine(Path.GetTempPath(),"nunesdevs-"+Guid.NewGuid()+".txt");
try { var file=new FileHelper();file.CriarArquivoTexto(path,"original");
 try { file.CriarArquivoTexto(path,"alterado"); throw new Exception("Arquivo sobrescrito"); } catch (IOException) {}
 Check(File.ReadAllText(path)=="original");
} finally { if (File.Exists(path)) File.Delete(path); }
Console.WriteLine("POO: crédito, overflow, divisão, medidas e arquivo preservado aprovados.");
