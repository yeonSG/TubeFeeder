# Tube Feeder
 - 장비 전원 On 후 단말기에서 Start를 누르면 제어보드를 통해 tube를 바코드에게 가져다 주면 읽은 바코드 번호를 저장하는 시스템
 - 단말기에 설치되어 제어장치와 바코드 리더기와 통신하며 제어하는 프로그램입니다.
 
## 하드웨어 구성
 - 임베디드 컴퓨터 : 사용자 인터페이스 제공, 모든 시스템 동작을 컨트롤함
 - 바코드 리더기 : 제품 바코드를 읽어 임베디드 컴퓨터로 전송해줌
 - 제어보드 : 임베디드 컴퓨터와 통신하며 기계들의 동작시킴

## 소프트웨어 요구사항
 ### 확인해볼 것
 - [x] 내 환경에서 빌드한 .exe 파일이 타겟 기기(windows ce)에서 실행 되는지 확인
 - [ ] ~~바코드 리더기 드라이버 설치 후 컴포트를 통해 데이터 얻어지는지 확인~~
 - [x] 바코드 리더기를 통해 데이터 얻어지는지 확인(키보드 입력형태로 데이터 입력되는 것 확인)
 - [x] 컴포트 rx,tx를 점프선으로 연결해 보내기와 받기 되는 것 확인
 - [ ] 단말기와 기계장치간 컴포트를 통해 데이터 오고가는 것 확인
 
 ### 개발 요구사항
 - [ ] 바코드 리더기로부터 바코드정보를 받음 
 - [ ] 받은 바코드정보를 저장함 (파일 또는 Excel, 각각 파일은 날짜 단위로 나눔)
 - [ ] 제어보드와의 통신 구현: 제어장치에게 전송(시작해라, 바코드 읽음, 모터속도 설정)
 - [ ] 제어보드와의 통신 구현: 제어장치로부터 수신(바코드 읽어라, 기계에 재밍이 발생함)

## Todo
> 기능 구현 목록
 - [x] 바코드 입력시 파일(./ScanLog/YYYYMMDD.txt)에 입력&저장
 - [x] 제어보드와의 통신기능 구현
 - [x] 제어보드 통신 프로토콜 정의
 - [x] 컴포트 통신 기능 구현
 - [x] 컴포트 통신 연결 
 
 > 추가(2020-12-09)
 - [ ] 레이아웃 변경(인디케이터 좀 좁게하고 로그창 오른쪽으로 밀기, 인디케이터 시작시-초록, 스탑시-회색, 에러-빨강 뜨도록)
 - [ ] 바코드 숫자입력이 아닐 때 에러뜨는 것 제거
 - [ ] 로그파일에 시간도 기록 (HH:MM:SS \t (data) )
 - [ ] 바코드 로그 뜨는곳 로그만 뜨도록 변경
 - [ ] 모든 폼 처리부분 invoke 처리(현재시간 출력 등등)
 - [ ] 에러 시 비프음 나도록
 - [ ] [전역 예외처리](https://hnsts.co.kr/ReferenceRoom/TechNoteView/8)
 - [ ] 런타임모드 쓰지말구 바로가기 만들기[링크_9번](https://hnsts.co.kr/ReferenceRoom/SmartxRelated)
 - [ ] 시작프로그램 등록하기 ->단말기 메뉴얼의 파트3-13번 레지스트리 등록,[시작프로그램 등록](https://periar.tistory.com/entry/WinCE-%EC%8B%9C%EC%9E%91%ED%94%84%EB%A1%9C%EA%B7%B8%EB%9E%A8)
 - [ ] 로그파일 쓰기시 에러발생 시 정지 및 경고 알려야함
 
> 이외 구현 목록
 - [ ] 에러 처리 (컴포트 연결 실패, 바코드 연결 실패 등등)
 - [ ] 메모리 용량 경고 (log 파일이 늘어남에 따라 저장용량에 대한 경고 필요)
 - [ ] GUI 정리

## 참고
 - 임베디드 컴퓨터 정보 (IEC1000)
   - [단말기 개요](https://www.hnsts.co.kr/Hardware/Iec1000)
   - [단말기 통합 개요](https://hnsts.co.kr//ReferenceRoom/ProductRelated#product5)
   - [단말기 메뉴얼](https://hnsts.co.kr/UserFiles/attachment/data_down/1-iecseries.pdf)
   - [단말기 스타팅개발 가이드](https://hnsts.co.kr/UserFiles/attachment/data_down/%EC%8A%A4%ED%83%80%ED%8C%85%EB%94%94%EB%B2%A8%EB%A1%9C%ED%8D%BC%EA%B0%80%EC%9D%B4%EB%93%9C-C.pdf)
   - [단말기 하드웨어 개요](https://www.hnsts.co.kr/Hardware/Iec1000)   
   - [UI 디자인 가이드_(Step2 참고)](https://hnsts.co.kr/ReferenceRoom/SmartxRelated)
   - Windows CE 6.0
  
 - 바코드 리더기 정보 
   - 3310G 하니웰(USB)
   - 인터페이스 : (usb 드라이버를 통한 comport통신, rs232통신 )
   - [메뉴얼-en](https://www.honeywellaidc.com/ko-kr/-/media/en/files-public/technical-publications/barcode-scanners/vuquest-3310g/3310-ug.pdf)
   - [퀵 메뉴얼-kr](https://aidc.honeywell.com/CatalogDocuments/3310-KO-QS%20Rev%20C%201-13.pdf)
   - usb 드라이버 다운로드 : http://idnext.co.kr/bbs/board.php?bo_table=4010&wr_id=29
   - usb 드라이버(WinCE용 참고): http://m.ezdaq.com/board/?id=board3&popup=&iframe=&goods_seq=&perpage=&page=&category=%EB%93%9C%EB%9D%BC%EC%9D%B4%EB%B2%84&search_text=
   - 바코드 presentation 모드와, streaming presentation모드 차이 : https://www.l-trondirect.com/blog/what-does-presentation-mode-mean-on-a-barcode-scanner/
 
 - 제어보드(MCU) 정보
   - 인터페이스 : comport serial rs232
