/// <reference path="product.js" />
// var start = 0;
// var nb = 4;
// var end = start + nb;
// var length = $('.img-list img').length;
// var list = $('.img-list img');

// list.hide().filter(':lt('+(end)+')').show();


// $('.prev, .next').click(function(e){
//   e.preventDefault();

//   if (($(this).hasClass('prev') && start > 0) || ($(this).hasClass('next') && end < length))
//   {

//     if( $(this).hasClass('prev') ){
//       start -= nb;
//     } else {
//       start += nb;
//     }

//     end = start + nb;

//     if((start/nb) < 1)
//     {
//       $('a.prev').html('Page 1');
//     }
//     else
//     {
//       $('a.prev').html('Page '+(start/nb));
//     }


//     if(end+nb > length) {
//       $('a.next').html('Page '+((end/nb)));
//     } else {
//       $('a.next').html('Page '+((end/nb)+1));
//     }
//   }

//   if( start == 0 ) list.hide().filter(':lt('+(end)+')').show();
//   else list.hide().filter(':lt('+(end)+'):gt('+(start-1)+')').show();
// });


// HINT : the groups of buttons to select as visible in the pagination pannel
function getCurrentPageGroup(currentPage = 1) {
  // HINT : when page 1 or 2 selected, the current position on <pagination /> targeted but when selected another
  // the page button targeted going to be the center position
  let exactCurrent = [1, 2].indexOf(currentPage) != -1 ? 1 : currentPage - 2;

  // HINT : from page and 5 length more page button visible to click
  let currentPageGroup = range(exactCurrent, exactCurrent + 4);

  return currentPageGroup;
}

function _animatePagination(btn, move = "top") {
  btn.classList.add(`pagination--move-${move}`);
  window.setTimeout(() => {
    btn.classList.remove(`pagination--move-${move}`);
  }, 850);
}

// HINT : by each click to the page button, update the <pagination /> pannel
// so, give the placeholder buttons list and change their text from currentPage
function updatePagination(currentPage = 1, BUTTONS, prevPage = 1) {
  let pageItems = getCurrentPageGroup(currentPage);

  // to change the current position if not 1 or 2
  let targetedPage = currentPage == 1 ? 0 : currentPage == 2 ? 1 : 2;

  // HINT : reset the all page button and if targeted was, cleared
  BUTTONS.map((btn, index) => {
    btn.removeAttribute(`data-level`);
    btn.textContent = pageItems[index];
  });

  // HINT : make bold font face of targeted button with replacement value
  BUTTONS[targetedPage].dataset.level = "target";
  let _temp_page_content_ = BUTTONS[targetedPage].textContent;
  BUTTONS[targetedPage].innerHTML = `<strong>${_temp_page_content_}</strong>`;
  _animatePagination(
    BUTTONS[targetedPage],
    currentPage == prevPage ? "top" : currentPage < prevPage ? "next" : "prev"
  );
}

//
// =================== APP =================== //
(function () {
  const PAGINATION = document.querySelector(`.pagination`);
  const BUTTON_PREV = document.querySelector(`#pg-button-prev`);
  const BUTTON_NEXT = document.querySelector(`#pg-button-next`);
  const BUTTONS = [
    document.querySelector(`#pg-button-1`),
    document.querySelector(`#pg-button-2`),
    document.querySelector(`#pg-button-3`),
    document.querySelector(`#pg-button-4`),
    document.querySelector(`#pg-button-5`)
  ];

  const state = {
    currentPage: 1
  };

  function _eventPagination(btn) {
    btn.addEventListener(
      `click`,
      () => {
        let lastPage = state.currentPage;
        state.currentPage = parseInt(btn.textContent);
        updatePagination(state.currentPage, BUTTONS, lastPage);
      },
      false
    );
  }

  // default pagination
  updatePagination(state.currentPage, BUTTONS);

  // pagination events
  PAGINATION.onmousedown = () => {
    BUTTONS.map((btn) => {
      (btn.classList.contains("pagination--move-next") &&
        btn.classList.remove("pagination--move-next")) ||
        (btn.classList.contains("pagination--move-prev") &&
          btn.classList.remove("pagination--move-prev")) ||
        (btn.classList.contains("pagination--move-top") &&
          btn.classList.remove("pagination--move-top"));
    });
  };

  BUTTONS.map((btn) => _eventPagination(btn));

  BUTTON_PREV.onclick = () => {
    let lastPage = state.currentPage;

    // HINT : to avoid error on number under 1
    state.currentPage = state.currentPage - 1 <= 1 ? 1 : state.currentPage - 1;
    updatePagination(state.currentPage, BUTTONS, lastPage);
  };
  BUTTON_NEXT.onclick = () => {
    let lastPage = state.currentPage;

    // TODO : if fetch the length of pages, remove this infinite pagination
    state.currentPage += 1;
    updatePagination(state.currentPage, BUTTONS, lastPage);
  };
})();

//
// =================== HELPER =================== //
function range(start = 0, stop, step = 1, func = { onPush: (index) => index }) {
  let from = stop ? start : 0;
  let to = stop ? stop : start;
  let _range = [];
  if (from < to) {
    for (let index = from; index <= to; index += step) {
      func.beforePush && func.beforePush(index);
      _range.push(func.onPush(index));
      func.afterPush && func.afterPush(index);
    }
  } else {
    for (let index = from; index >= to; index -= step) {
      func.beforePush && func.beforePush(index);
      _range.push(func.onPush(index));
      func.afterPush && func.afterPush(index);
    }
  }
  return _range;
}
