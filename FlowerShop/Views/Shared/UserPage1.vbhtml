<!DOCTYPE html>

<html>
<head>
    <title>
        FLOWER SHOP
    </title>
    <link href="~/Content/Style.css" rel="stylesheet" />
    
</head>
<body>
    <div id="container">
        <div id="banner">
            <div class="header">
                <div id="logo">
                    <img class="logo" src="~/Images/unnamed.jpg" />
                </div>
                <form>
                    <input type="text" name="search" placeholder="Search..">
                </form>
            </div>

            <div id="menutop">
                <a href="#">Trang chủ</a>
                <a href="#">Giới thiệu</a>
                <a href="#">Sản phẩm</a>
                <a href="#">Chủ đề</a>
                <a href="#">Màu sắc</a>
                <a href="#">Khuyến mãi</a>
                <a href="#">Liên hệ</a>
            </div>
        </div><!--hetbanner-->
        <div id="content">
            <div id="left">
                <div class="module">
                    <h3>Danh mục sản phẩm</h3>
                    <a href="#">Bó hoa tươi</a>
                    <a href="#">Hộp hoa tươi</a>
                    <a href="#">Mẫu hoa mới</a>
                    <a href="#">Giỏ hoa tươi</a>
                    <a href="#">Bình hoa tươi</a>
                    <a href="#">Hoa tình yêu</a>
                    <a href="#">Hoa chúc mừng</a>
                    <a href="#">Hoa chia buồn</a>
                </div>
                <div class="module">
                    <h3>Trạng thái</h3>
                    <a href="#">Mới về</a>
                    <a href="#">Nổi bật</a>
                    <a href="#">Đang giảm giá</a>
                    <a href="#">Còn hàng</a>
                </div>
                <div class="module">
                    <h3>Màu sắc</h3>
                    <a href="#">Đỏ</a>
                    <a href="#">Đỏ-vàng</a>
                    <a href="#">Đỏ-Hồng-Trắng</a>
                    <a href="#">Hồng-Xanh-Lá</a>
                </div>

            </div><!--hetleft-->
            <div id="right">
                <div id="slideshow">
                    <img class="imga1" src="https://bonn.vn/wp-content/uploads/2017/07/6ru.jpg" />

                </div>
                <div>
                    @RenderBody
                </div>
                <div id="products">
                    <h3 class="header">Sản phẩm khuyến mãi</h3>
                    <div class="item">
                        <h3 class="productName">Sweet Rossie</h3>
                        <img class="productImg" src="~/Images/SPkhuyenmai/11043_sweet-rossie.png" width="150" />
                        <p class="productPrice">1,000,000 VND</p>
                        <a class="productDetail" href="#">Chi tiết</a>
                        <a class="productBuy" href="#">Mua hàng</a>
                    </div>
                    <div class="item">

                        <h3 class="productName">Hạnh phúc bất tận</h3>

                        <img class="productImg" src="~/Images/SPkhuyenmai/11044_hanh-phuc-bat-tan-2.png" width="150" />
                        <p class="productPrice">900,000 VND</p>
                        <a class="productDetail" href="#">Chi tiết</a>
                        <a class="productBuy" href="#">Mua hàng</a>
                    </div>
                    <div class="item">
                        <h3 class="productName">Bình hồng đỏ ớt</h3>

                        <img class="productImg" src="~/Images/SPkhuyenmai/11604_hong-do-ot-25-bong.jpg" width="150" />
                        <p class="productPrice">300,000 VND</p>
                        <a class="productDetail" href="#">Chi tiết</a>
                        <a class="productBuy" href="#">Mua hàng</a>
                    </div>
                    <div class="item">
                        <h3 class="productName">Bình hồng vàng AT</h3>

                        <img class="productImg" src="~/Images/SPkhuyenmai/11673_binh-hong-vang-at-30.jpg" width="150" />
                        <p class="productPrice">300,000 VND</p>
                        <a class="productDetail" href="#">Chi tiết</a>
                        <a class="productBuy" href="#">Mua hàng</a>
                    </div>
                    <div class="item">
                        <h3 class="productName">Kem hoa</h3>

                        <img class="productImg" src="~/Images/SPkhuyenmai/11739_kem-hoa.png" width="150" />
                        <p class="productPrice">150,000 VND</p>
                        <a class="productDetail" href="#">Chi tiết</a>
                        <a class="productBuy" href="#">Mua hàng</a>
                    </div>
                    <div class="item">
                        <h3 class="productName">Sum họp</h3>
                        <img class="productImg" src="~/Images/SPkhuyenmai/4520_sum-hop.jpg" width="150" />
                        <p class="productPrice">400,000 VND</p>
                        <a class="productDetail" href="#">Chi tiết</a>
                        <a class="productBuy" href="#">Mua hàng</a>
                    </div>
                </div>
            </div>
            <div id="products">
                <h3 class="header">Bó hoa</h3>
                <div class="item">
                    <h3 class="productName">Ánh dương</h3>

                    <img class="productImg" src="~/Images/BoHoa/2065_anh-duong.jpg" width="150" />
                    <p class="productPrice">150,000 VND</p>
                    <a class="productDetail" href="#">Chi tiết</a>
                    <a class="productBuy" href="#">Mua hàng</a>
                </div>
                <div class="item">

                    <h3 class="productName">Yêu xa</h3>

                    <img class="productImg" src="~/Images/BoHoa/3199_yeu-xa.jpg" width="150" />
                    <p class="productPrice">200,000 VND</p>
                    <a class="productDetail" href="#">Chi tiết</a>
                    <a class="productBuy" href="#">Mua hàng</a>
                </div>
                <div class="item">
                    <h3 class="productName">Only You</h3>

                    <img class="productImg" src="~/Images/BoHoa/4840_only-you.jpg" width="150" />
                    <p class="productPrice">180,000 VND</p>
                    <a class="productDetail" href="#">Chi tiết</a>
                    <a class="productBuy" href="#">Mua hàng</a>
                </div>

            </div>
            <div id="products">
                <h3 class="header">Giỏ Hoa</h3>
                <div class="item">
                    <h3 class="productName">Mùa xuân của mẹ</h3>

                    <img class="productImg" src="~/Images/GioHoa/10262_mua-xuan-cua-me.png" width="150" />
                    <p class="productPrice">600,000 VND</p>
                    <a class="productDetail" href="#">Chi tiết</a>
                    <a class="productBuy" href="#">Mua hàng</a>
                </div>
                <div class="item">

                    <h3 class="productName">Nắng hồng</h3>

                    <img class="productImg" src="~/Images/GioHoa/10267_nang-hong.png" width="150" />
                    <p class="productPrice">500,000 VND</p>
                    <a class="productDetail" href="#">Chi tiết</a>
                    <a class="productBuy" href="#">Mua hàng</a>
                </div>
                <div class="item">
                    <h3 class="productName">Pink Box</h3>

                    <img class="productImg" src="~/Images/GioHoa/8290_pink-box.jpg" width="150" />
                    <p class="productPrice">800,000 VND</p>
                    <a class="productDetail" href="#">Chi tiết</a>
                    <a class="productBuy" href="#">Mua hàng</a>
                </div>

            </div>
        </div>
    </div><!--hetright-->
    <div class="clear">

    </div>
    </div><!--hetcontent-->
    <div id="footer">
        <p>Bản quyền thuộc về: <b>ABCXYZ</b></p>
        <p>Mẫu website được thiết kế bởi: <b><a href="http://www.google.com">webdesiner</a></b></p>
    </div><!--footer-->
    </div><!--hetconterner-->
</body>
</html>
