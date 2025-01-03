# 指定時にのみ表示-YMM4プラグイン
## 概要
不透明度を再生時、一時停止時、出力時に分けて設定できる映像エフェクトプラグインです。  
映像エフェクトの描画カテゴリに「**指定時にのみ表示**」を追加します。
## 導入方法
[Releases](https://github.com/tetra-te/SpecifiedShowEffect/releases/latest)から`SpecifiedShowEffect.ymme`をダウンロードします。  

ダウンロードしたファイルを開いて、表示される画面に従ってインストールしてください。  
または、ダウンロードしたファイルをYMM4にドラッグアンドドロップして、表示される画面に従ってインストールしてください。
## 使用方法
映像エフェクトの描画カテゴリから「**指定時にのみ表示**」を追加してください。  
再生時、一時停止時、出力時のそれぞれで不透明度を指定できます。不透明度はYMM4デフォルトの不透明度エフェクトと同様に、乗算して適用されます。
### 最適化
最適化を有効にすると、不透明度が0%のときに拡大率も0%に設定するようになります。これにより、高速化や軽量化する可能性があります。
通常、この設定によって画像の見た目は変わりませんが、最適化によって非表示にされたアイテムはプレビューエリアでのドラッグなどの操作ができなくなります。
## アンインストール方法
YMM4を起動して、`ヘルプ(H)`>`その他`>`プラグインフォルダを開く`をクリックしてください。  
`SpecifiedShowEffect`という名前のフォルダを削除することでアンインストールできます。
## ライセンス
[MIT License](./LICENSE)