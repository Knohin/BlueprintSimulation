# BlueprintSimulation

산학연계 프로젝트

Team 가젤이젤디젤

Introduction
------------
<div>
 <img width="700" src="https://user-images.githubusercontent.com/33307479/40827208-e7bfd38c-65b7-11e8-843d-276e1d8fef35.png">
</div>

Ready To Use
--------------
1. Ground Plaen기능 지원 기기를 확인한다.
    지원 기기 목록 : https://library.vuforia.com/articles/Solution/ground-plane-supported-devices.html
    지원 되지 않는 기기의 경우 ‘살펴보기’ 기능을 사용할 수 없다.(그 외의 기능은 부분적으로 사용 가능하다.)
2. AR기능을 사용하기 위한 마커이미지를 출력한다. (복제물에 포함)

How To Use
-----------
이미지 인식을 통해 여러가지 마커위에 다양한 가구를 생성한다. 마커를 이용한 인테리어 기능은 다음과 같다.
1. 생성된 가구는 마커를 직접 손으로 움직여가며 테이블 위에서 인테리어를 한다.
   - 가구를 클릭하여 가구의 색상을 변경할 수 있다.
   - 가구 배치 시, 벽 또는 다른 가구와 겹치는 부분이 있다면 설치가 불가함을 가구가 빨간색으로 표시됨으로써 알려준다.
   - 냉장고, 장롱의 경우 클릭을 통해 상호작용한다. 문이 열리는 동작을 보여줌으로서 유동적인 형태에 따라 걸리는 곳이 없는지 판단할 수 있다.
   - 싱크대, 오븐, 스탠드, 가스레인지의 경우 클릭을 통하여 불이 켜지거나, 물이 흐르는 것과 같은 모습을 보여준다.
2. 왼쪽 위의 벽돌을 클릭하여 사용자가 자신의 집 크기를 미터단위로 가로/세로를 입력하면 방 마커에 축소된 비율에 맞게 벽이 표시 된다.
3. '메뉴 - 저장하기'를 통해 방 안에 가구들이 인테리어된 상태를 저장할 수 있다.
4. '메뉴 - 살펴보기'를 통해 바닥 마커를 인식후 저장한 파일을 불러와 실 사이즈를 휴대폰 화면을 통해 볼 수 있다.
